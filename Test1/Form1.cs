using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataReader(); //Reads the file 
            radExpress.Checked = true; //Express as default 
            chkFragile.Checked = true; //Fragile as default 
            lstPackages.DisplayMember = "trackingNumber"; //lists only the tracking numbers from files 
        }

        private void DataReader() //Reads the txt file 
        {
            string filePath = @"ShippingFile1.txt"; //finds the file attached in bin 

            if (File.Exists(filePath)) //checks if file exists 
            {
                var lines = File.ReadAllLines(filePath); //read all lines in ShippingFile1 

                foreach (var line in lines) //for each line it reads...
                {
                    var data = line.Split(','); //seperate fields (data) using the commas 

                    if (data.Length >= 14) //ensures only 14 fields exists for each line (otherwise it crashes) 
                    {
                        var package = new ShippingApp.PackageInfo //use PackageInfo to create a new "package" 
                        {
                            trackingNumber = data[0], 
                            recipientName = data[1],
                            streetAddress = data[2],
                            city = data[3],
                            state = data[4],
                            postalCode = data[5],
                            emailAddress = data[6],
                            phoneNumber = data[7],
                            dateShipped = data[8],
                            dateDelivered = data[9],
                            packageWeight = data[10],
                            carrier = data[11],
                            deliveryMode = data[12],
                            isFragile = data[13],
                        };

                        lstPackages.Items.Add(package); //adds the file's packages to the list box 
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ERRORS 
            epValidate.Clear(); //clears all previous errors 
            bool hasErrors = false; //default 

            if (String.IsNullOrWhiteSpace(txtTrackingNumber.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtTrackingNumber, "Tracking # cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtRecipient.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtRecipient, "Recipient cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtAddress, "Address cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtCity.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtCity, "City cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtState.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtState, "State cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtPostalCode, "Postal Code cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtEmail, "Email cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtPhone.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtPhone, "Phone cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtShipDate.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtShipDate, "Ship Date cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtWeight.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtWeight, "Weight cannot be empty.");
            }

            if (cboCarrier.SelectedIndex == -1) 
            {
                hasErrors = true;
                epValidate.SetError(cboCarrier, "Select a carrier.");
            }

            if (!radExpress.Checked && !radOvernight.Checked && !radStandard.Checked)
            {
                hasErrors = true;
                epValidate.SetError(radExpress, "Select a Shipping Mode.");
                epValidate.SetError(radOvernight, "Select a Shipping Mode.");
                epValidate.SetError(radStandard, "Select a Shipping Mode.");
            }

            if (hasErrors)
            {
                return; 
                //initially I had a return in every if error statement, but to match the 
                //image you showed in the document, I chose to do this instead 
            }

            //creates a new package only if it passes epValidate 
            //had to create additionalPackage as DataReader already uses var package 
            var additionalPackage = new ShippingApp.PackageInfo
            {
                trackingNumber = txtTrackingNumber.Text,
                recipientName = txtRecipient.Text,
                streetAddress = txtAddress.Text,
                city = txtCity.Text,
                state = txtState.Text,
                postalCode = txtPostalCode.Text,
                emailAddress = txtEmail.Text,
                phoneNumber = txtPhone.Text,
                dateShipped = txtShipDate.Text,
                dateDelivered = txtDeliveryDate.Text,
                packageWeight = txtWeight.Text,
                carrier = cboCarrier.SelectedItem?.ToString(),
                deliveryMode = radExpress.Checked ? "Express" : radOvernight.Checked ? "Overnight" : "Standard",
                isFragile = chkFragile.Checked.ToString()
            };

            //adds the additional package to the list box + message 
            lstPackages.Items.Add(additionalPackage);
            MessageBox.Show("A new package has been added!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //since everything is in lstPackages, a selectedItem shows all PackageInfo data of the selectedPackage
            if (lstPackages.SelectedItem is ShippingApp.PackageInfo selectedPackage)
            {
                txtTrackingNumber.Text = selectedPackage.trackingNumber;
                txtRecipient.Text = selectedPackage.recipientName;
                txtAddress.Text = selectedPackage.streetAddress;
                txtCity.Text = selectedPackage.city;
                txtState.Text = selectedPackage.state;
                txtPostalCode.Text = selectedPackage.postalCode;
                txtEmail.Text = selectedPackage.emailAddress;
                txtPhone.Text = selectedPackage.phoneNumber;
                txtShipDate.Text = selectedPackage.dateShipped;
                txtDeliveryDate.Text = selectedPackage.dateDelivered;
                txtWeight.Text = selectedPackage.packageWeight;
                cboCarrier.SelectedItem = selectedPackage.carrier;
                radExpress.Checked = selectedPackage.deliveryMode == "Express";
                radOvernight.Checked = selectedPackage.deliveryMode == "Overnight";
                radStandard.Checked = selectedPackage.deliveryMode == "Standard";
                chkFragile.Checked = selectedPackage.isFragile.ToLower() == "true";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //checks if weight is a number 
            if (!double.TryParse(txtWeight.Text, out double weight))
            {
                MessageBox.Show("Enter a valid weight.");
                return;
            }

            //finds what shipping mode the current package has selected using ?: (if else) 
            //if radStandard is checked, it's Standard, if not it's Express, but if radExpress 
            //isn't checked, then it's Overnight 
            string mode = radStandard.Checked ? "Standard" : radExpress.Checked ? "Express" : "Overnight";

            //Calculations 
            double baseRate = 0;
            double perPoundRate = 0;

            if (mode == "Standard") 
            {
                baseRate = double.Parse(ConfigurationManager.AppSettings["StandardShippingBaseRate"]);
                perPoundRate = double.Parse(ConfigurationManager.AppSettings["StandardShippingPerPoundRate"]);
            }
            else if (mode == "Express")
            {
                baseRate = double.Parse(ConfigurationManager.AppSettings["ExpressShippingBaseRate"]);
                perPoundRate = double.Parse(ConfigurationManager.AppSettings["ExpressShippingPerPoundRate"]);
            }
            else if (mode == "Overnight")
            {
                baseRate = double.Parse(ConfigurationManager.AppSettings["OvernightShippingBaseRate"]);
                perPoundRate = double.Parse(ConfigurationManager.AppSettings["OvernightShippingPerPoundRate"]);
            }

            //Results 
            double totalCost = baseRate + (perPoundRate * weight);
            lblShippingCost.Text = $"Shipping Cost: ${totalCost:F2}";
        }
    }
}
