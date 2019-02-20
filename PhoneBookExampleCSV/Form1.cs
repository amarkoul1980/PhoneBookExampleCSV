using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneBookExampleCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
//The widths of each column of the ListView are pre-defined
            lstvPhoneNumbers.Columns[0].Width = 150;
            lstvPhoneNumbers.Columns[1].Width = 150;
            lstvPhoneNumbers.Columns[2].Width = 150;
            lstvPhoneNumbers.Columns[3].Width = 150;
        }

/*
     Class of a specific phone number, containing the following attributes:

     Surname
     Name
     Number
     Activated (true if the number is active, false if not)
*/
        public class PhoneNumber
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
            public string Activated { get; set; }
        }

        int lstvSelectedIndex = -1; //The selected index of the ListView
        List<PhoneNumber> lstPhones= new List<PhoneNumber>(); //List of PhoneNumbers
        // The lstPhoneIndices list contains the indices of the phone number records shown in the list view
        // When the list view is cleared and filled with new data (i.e. when the user wants to get specific phone numbers)
        // the list is updated so that the indices of the newly presented data will be stored.
        //
        // Example: Let us suppose that initially the list view contains the following data
        //
        // User1    Phone0      Activated0
        // User2    Phone1      Activated1
        // User2    Phone2      Activated2
        // User3    Phone3      Activated3
        // User4    Phone4      Activated4
        // User4    Phone5      Activated5
        // User5    Phone6      Activated6
        //
        // In this case, the lstPhoneIndices will contain the values [0,1,2,3,4,5,6] (zero-indexed)
        //
        // If the user wants to show the phone numbers for the User4, the list view will become like this:
        //
        // User4    Phone5      Activated5
        // User4    Phone6      Activated6
        //
        // while the lstPhoneIndices will contain the values [5,6]
        List<int> lstPhoneIndices = new List<int>();


        /*
                The following method is run when the "Get All Phone Numbers" button is pressed.

                This method is run only once, in order to load the data from the CSV file. After its execution, the button becomes disabled.
        */
        private void btnGetAllPhoneNumbers_Click(object sender, EventArgs e)
        {
            int lstPhoneNumberCounter = 0;

            lstvPhoneNumbers.Items.Clear();

            StreamReader reader = new StreamReader(File.OpenRead("phones.csv"));

            cmbPhoneNames.Items.Add("All Numbers"); //Adds the possibility to view the whole phone list
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(','); //Splits the retrieved line -the separator is ','

                    //The data retrieved from the read line are stored in a PhoneNumber variable, in order to be put into the list
                    PhoneNumber phoneNumber = new PhoneNumber();
                    phoneNumber.Surname = values[0];
                    phoneNumber.Name = values[1];
                    phoneNumber.Number = values[2];
                    phoneNumber.Activated = values[3];
                    if (values[3] == "0") phoneNumber.Activated = "false";
                    else phoneNumber.Activated = "true";

                    lstPhones.Add(phoneNumber); //PhoneNumber record is added into the phone list
                    lstPhoneIndices.Add(lstPhoneNumberCounter++); //The PhoneNumber record index is added into the phone indices list

                    //Filling the list view
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = values[0];
                    lvi.SubItems.Add(values[1]);
                    lvi.SubItems.Add(values[2]);
                    if (values[3]=="0") lvi.SubItems.Add("false");
                    else lvi.SubItems.Add("true");
                    lstvPhoneNumbers.Items.Add(lvi);

                    //Filling the combo box (and checking for duplicates)
                    if (!cmbPhoneNames.Items.Contains(values[0] + " " + values[1]))
                    {
                        cmbPhoneNames.Items.Add(values[0] + " " + values[1]);
                    }
                }
            }

            reader.Close();
            btnGetAllPhoneNumbers.Enabled = false;
            label1.Enabled = true;
            cmbPhoneNames.Enabled = true;
        }

/*
        The following method is called when the user selects a name from the combo box.

        The only parameter of the method is an integer symbolizing the selected index of the combo box. Its default value is 0 -so that the whole list is viewed

        At first, the list view is cleared so that the data requested are to be shown.  Also, the phone list indices list is cleared.
        Then, the whole list is checked.

        If the value of the index parameter is 0 (that is the whole list is going to be viewed), the list records are stored in the list view
        If not, the program checks whether the list record full name (surname + " " + name) is equal to the name selected in the combobox.
                    If it is, the list record is  stored in the list view
*/
        private void fillListView(int index = 0)
        {
            lstvPhoneNumbers.Items.Clear();
            lstPhoneIndices.Clear();
            for (int i=0;i<lstPhones.Count; i++)
            {
                string fullName = lstPhones[i].Surname + " " + lstPhones[i].Name;
                if ((index==0) || (cmbPhoneNames.Text==fullName))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = lstPhones[i].Surname;
                    lvi.SubItems.Add(lstPhones[i].Name);
                    lvi.SubItems.Add(lstPhones[i].Number);
                    lvi.SubItems.Add(lstPhones[i].Activated);

                    lstvPhoneNumbers.Items.Add(lvi);
                    lstPhoneIndices.Add(i);
                }
            }
        }

/*
        The following method is run when the user selects a name from the combo box. It calls the fillListView method
*/
        private void cmbPhoneNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListView(cmbPhoneNames.SelectedIndex);
        }

/*
        Gets the selected index of the list view (useful for the "Activate Phone Number" method)

        If the "Activate" value of the selected record is "true" the  "Activate Phone Number" button becomes enabled
*/
        private void lstvPhoneNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.lstvPhoneNumbers.SelectedIndices;

            foreach (int index in indexes)
            {
                lstvSelectedIndex = index;
                if (lstvPhoneNumbers.Items[index].SubItems[3].Text == "false") btnActivatePhoneNumber.Enabled = true;
                else btnActivatePhoneNumber.Enabled = false;
            }
        }

/*
        Activates a phone number, sets the "true" value in the respective field and updates the phone list
*/
        private void btnActivatePhoneNumber_Click(object sender, EventArgs e)
        {
            lstvPhoneNumbers.Items[lstvSelectedIndex].SubItems[3].Text = "true";
            lstPhones[lstPhoneIndices[lstvSelectedIndex]].Activated = "true";

            btnActivatePhoneNumber.Enabled = false;
        }
    }
}
