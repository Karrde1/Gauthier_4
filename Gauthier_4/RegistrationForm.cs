// Programmer: Gregory Gauthier
// Project: Assignment 4
// Due Date: 04/14/2018
// Description: Individual Assignment #4

using System;
using System.Windows.Forms;
using System.IO;

namespace Gauthier_4
{
    public partial class RegistrationForm : Form
    {

        // Class Level Constants 
        private const decimal LIVE_ACTION = 79.95m; 
        private const decimal ANIMATION = 99.95m;
        private const decimal MAXIMUM_CLASSES = 4;

        // Declare Class Level Variables
        private decimal classPrice;
        private decimal totalRegistrationCost = 0.00m;
        private int numClassesSelected = 0;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Execute the following arguments immediately after program load
        private void HopkinsFilmSchool_Load(object sender, EventArgs e)
        {

            // On form load, set the Cash Radio Button to Checked
            cashRadioButton.Checked = true;

            // On form load, set the Receipt Option to Unchecked
            receiptRequestCheckBox.Checked = false;

            // Set Masked Date Text Box to Automatically Update with the Current Date when the form loads\
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Create an array that populates the Registrant Status Combo Box

            string[] status = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };

            // Load the Names from the Array into the Combo Box
            for (int i = 0; i < status.Length; i++)
                registrantStatusComboBox.Items.Add(status[i]);

            // Default Select the Live Action class option
            liveActionRadioButton.Checked = true;

            // Populate the Class Type List Box
            PopulateBoxes();

            // Sort the Items in the list box Alphabetically and Allow the selection of multiple Items
            classTypeListBox.Sorted = true;
            classTypeListBox.SelectionMode = SelectionMode.MultiSimple;


            // Assign ToolTips to the Menu Strip Items
            saveToolStripMenuItem.ToolTipText = "Click here to save the registration information to a text file and display the summary";
            clearToolStripMenuItem.ToolTipText = "Click here to clear and reset the form";
            exitToolStripMenuItem.ToolTipText = "Click here to Close the Form";
            aboutToolStripMenuItem.ToolTipText = "Click here to display information about our program";

        }
        // Handle the live action radio button checked changed event
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateBoxes(); // Execute the custom method to populate the List Box           
        }
        // Handle the animation radio button checked changed event
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateBoxes(); // Execute the custom method to populate the List Box
        }

        // This custom method will update the display of the registration cost totals based on user selection
        private void UpdateTotals()

        {
            // Add the Class Charge based on the Category Selected
          if (liveActionRadioButton.Checked)
            {
                classPrice = LIVE_ACTION;
            }
          else if (animationRadioButton.Checked)
            {
                classPrice = ANIMATION;
            }

            // Calculate the total cost of registration and assign the amount to a string, then a label
            totalRegistrationCost = classPrice * numClassesSelected;
            registrationFeeLabel.Text = totalRegistrationCost.ToString("C");

        }
        // This Custom Method will run every time a Class Category Radio button is selected
        private void PopulateBoxes()


        {
            // Reset the values for the appropriate variables each time the custom method is run
            numClassesSelected = 0;
            classesSelectedLabel.Text = "0";
            registrationFeeLabel.Text = "0.00";
            // Check if either class category radio button is selected and assign the appropriate value
            if (liveActionRadioButton.Checked == true)
            {
                
                pricePerClassLabel.Text = LIVE_ACTION.ToString("C");
            }

            else
            {
                pricePerClassLabel.Text = ANIMATION.ToString("C");
            }

            try // Ensure that the program can read the file
            {
                {
                    // If The Live Action radio button is checked, populate the list box accordingly
                    if (liveActionRadioButton.Checked)
                    {
                        classTypeListBox.Items.Clear();
                        StreamReader inputFile; // Declare StreamReader object for use in reading files

                        inputFile = File.OpenText("LiveActionClasses.txt"); // Open file with Live Action Class Types
                        while (!inputFile.EndOfStream) // Verify that more data exists to be read
                        {
                            // Read a line from input file and add it to combo box
                            classTypeListBox.Items.Add(inputFile.ReadLine());
                        }
                    }
                    // Otherwise if the Animation Radio Button is Checked, Clear the List Box and Populate  the list Box accordingly
                    else if (animationRadioButton.Checked)
                    {
                        classTypeListBox.Items.Clear();
                        StreamReader inputFile; // Declare StreamReader object for use in reading files

                        inputFile = File.OpenText("AnimationClasses.txt"); // Open file with Animation Class Types
                        while (!inputFile.EndOfStream) // Verify that more data exists to be read
                        {
                            // Read a line from input file and add it to combo box
                            classTypeListBox.Items.Add(inputFile.ReadLine());
                        }
                        inputFile.Close(); // Close the input file when done reading values.
                    }

                }
            }

            catch (Exception ex)
            {
                // Display message if error occurs when attempting to read either file
                MessageBox.Show(ex.Message);
            }

          }
        // Describing the Class Type List Box Index Changed Event Handler
        private void classTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numClassesSelected = classTypeListBox.SelectedIndices.Count;
            classesSelectedLabel.Text = numClassesSelected.ToString();
            UpdateTotals();
        }

        // Handle the Save Tool Strip Menu Item Click Event
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if any of the following fields are empty, or if the amount of classes is less than or exceeds the appropriate value.
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailMaskedTextBox.Text == "" || dateOfBirthMaskedTextBox.MaskCompleted == false)
            {
                MessageBox.Show("Registrant Name,Email Address, \n and Date of Birth, Must be completed.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numClassesSelected < 1 || numClassesSelected > MAXIMUM_CLASSES)
            {
                MessageBox.Show("At least 1 Class, but no more than " + MAXIMUM_CLASSES + " classes, \n must be selected in order to register.", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // If the fields are completed properly and the classes selected value is within range, Attempt the following:
            else
            {
                try // Attempt to save the following data to a Text File and Display in a Message box.
                {
                    string paymentOption = ""; // Create the payment option string

                    if (cashRadioButton.Checked) // If the cash or check option is selected, save the appropriate response 
                    {
                        paymentOption = "Cash";
                    }
                    else if (checkRadioButton.Checked)
                    {
                        paymentOption = "Check";
                    }
                    string classesSelected = ""; // Hold a concatenated multiline list of the classes selected

                    // Loop through all of the items in the class type list box and assign the value for each selected.
                    for (int counter = 0; counter < classTypeListBox.Items.Count; counter++)
                    {
                        // Use the GetSelcted method to determine if the list box item is selected or not
                        if (classTypeListBox.GetSelected(counter))
                        {
                            classesSelected += classTypeListBox.Items[counter] + "\n";
                        }
                    }
                    // Assign the Receipt Requested String
                    string receiptRequested = "";
                    // Assign the response Yes if the box is checked
                    if (receiptRequestCheckBox.Checked == true)
                    {
                        receiptRequested = "Yes";
                    }
                    // Assign the response No if the box is not checked
                    else if (receiptRequestCheckBox.Checked == false)
                    {
                        receiptRequested = "No";
                    }

                    // Display a Message Box with the Registration Summary
                    MessageBox.Show("Registration Date" + " " + registrationDateMaskedTextBox.Text + "\n" +
                        "Registrant Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                        "Email Address:" + " " + emailMaskedTextBox.Text + " " + "\n" +
                        "Date of Birth:" + " " + dateOfBirthMaskedTextBox.Text + " " + "\n" +
                        "Professional Status:" + " " + registrantStatusComboBox.Text + "\n" +
                        "Classes Selected:" + " " + "\n" + classesSelected + " " + "\n" +
                        "Price Per Class:" + " " + classPrice + "\n" +
                        "Total Registration Cost:" + " " + totalRegistrationCost.ToString("C") + " " + "\n" +
                        "Payment Type:" + " " + paymentOption + "\n" +
                        "Email Receipt Requested:" + " " + receiptRequested,
                        "Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StreamWriter outputFile; // Declare Streamwriter for use in writing to a file
                    outputFile = File.AppendText("RegistrationData.Txt"); // Append new data to the existing data

                    // Write the registration summary to a text file.
                    outputFile.WriteLine("Registration Date:" + " " + registrationDateMaskedTextBox.Text);
                    outputFile.WriteLine("First and Last Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                    outputFile.WriteLine("Email Address:" + " " + emailMaskedTextBox.Text);
                    outputFile.WriteLine("Date of Birth:" + " " + dateOfBirthMaskedTextBox.Text);
                    outputFile.WriteLine("Professional Status:" + " " + registrantStatusComboBox.Text);
                    outputFile.WriteLine("Classes Selected:");
                    // Loop through all items in list box and write selected items to output file
                    for (int count = 0; count < classTypeListBox.Items.Count; count++)
                    {
                        // Use GetSelected method to determine if a list box item is selected or not
                        if (classTypeListBox.GetSelected(count))
                        {
                            outputFile.WriteLine(classTypeListBox.Items[count]); // Write to file with each entry on a new line
                        }
                    }
                    outputFile.WriteLine("Price Per Class:" + " " + classPrice);
                    outputFile.WriteLine("Total Registration Cost:" + " " + totalRegistrationCost.ToString("C"));
                    outputFile.WriteLine("Payment Type:" + " " + paymentOption);
                    outputFile.WriteLine("Email Receipt Requested:" + " " + receiptRequested);

                    outputFile.WriteLine(); // Write blank line to separate orders
                    outputFile.Close(); // Close the output file after writing data
                    
                }
                catch (Exception ex)
                {
                    // Display a message if an error occurs while writing the data to the message box or text file
                    MessageBox.Show(ex.Message);
                }
                // Call the Custom Reset Form Method Once the Data has been Saved
                ResetForm();
            }
        }
        // This custom method resets the form, returning it to its original state
            private void ResetForm()
        {
            // Reset all form controls to original state
            numClassesSelected = 0;
            classesSelectedLabel.Text = "0";
            registrationFeeLabel.Text = "0.00";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailMaskedTextBox.Text = "";
            registrantStatusComboBox.Text = "";
            receiptRequestCheckBox.Checked = false;
            dateOfBirthMaskedTextBox.Text = "";
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            liveActionRadioButton.Checked = true;
            cashRadioButton.Checked = true;
            classTypeListBox.ClearSelected();
            checkRadioButton.Checked = false;
            cashRadioButton.Checked = true;

            // Once the form has been reset, run the Update Totals function to reset the values as well.
            UpdateTotals();
        }
        // Handle the Clear tool Strip Menu Item Click Event
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call the Reset Form Method whenever the clear menu item is clicked.
            ResetForm();
        }
        // Handle the exit tool strip menu item click event.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare local variable to hold user selection in dialog box
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take appropriate action based on user selection in dialog box
            if (selection == DialogResult.Yes)
            {
                this.Close(); // Close the form (ending the program)
            }

        }
        // Handle the about menu item click event
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the AboutForm form class
            AboutForm myAboutForm = new AboutForm();

            // Display AboutForm instance as a modal form
            myAboutForm.ShowDialog();
        }
    }
    }


    


