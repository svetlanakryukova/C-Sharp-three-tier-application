using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryBikeBusLayer;
using ClassLibraryBikeDataLayer;


namespace prjWinForm_MyBike
{
    public partial class Form1 : Form
    {
        List<Bike> BikeList = new List<Bike>();
       
        int index = -1;
        int posBikeType = -1 , posColor=-1, posSuspType=-1, posBrakesType=-1, posTiresType=-1;


            public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox_Bike.HorizontalScrollbar = true; 
            listBox_Bike.ScrollAlwaysVisible = true;
            
            foreach (EnumBikeType item in Enum.GetValues(typeof(EnumBikeType)))
            {
                this.comboBox_BikeType.Items.Add(item);
            }

            this.comboBox_BikeType.Text = Convert.ToString(this.comboBox_BikeType.Items[0]);


            foreach (EnumSuspension item in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBox_SuspType.Items.Add(item);
            }

            this.comboBox_SuspType.Text = Convert.ToString(this.comboBox_SuspType.Items[0]);

            foreach(EnumBrakesType item in Enum.GetValues(typeof(EnumBrakesType)))
            {
                this.comboBox_BrakesType.Items.Add(item);
            }
            this.comboBox_BrakesType.Text = Convert.ToString(this.comboBox_BrakesType.Items[0]);

            foreach(EnumTiresType item in Enum.GetValues(typeof(EnumTiresType)))
            {
                this.comboBox_TiresType.Items.Add(item);
            }
            this.comboBox_TiresType.Text = Convert.ToString(this.comboBox_TiresType.Items[0]);

            foreach(EnumColor item in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBox_Color.Items.Add(item);
            }
            this.comboBox_Color.Text = Convert.ToString(this.comboBox_Color.Items[0]);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) { }


            Date anDate = new Date();
            Bike aBike;
            
            long serialNumber;
            int dm, dd, dy, frameSize, riderHeigth;
            string make;
            double speed, price, seatTubeHeight;
            
              if (!String.IsNullOrEmpty(texboxSerialNumber.Text)
                 && !String.IsNullOrEmpty(textBox_Make.Text)
                   && !String.IsNullOrEmpty(textBox_Speed.Text)
                     && !String.IsNullOrEmpty(textBox_Price.Text)
                      && !String.IsNullOrEmpty(textBoxMadeDate_Month.Text)
                        && !String.IsNullOrEmpty(textBoxMadeDate_Day.Text)
                          && !String.IsNullOrEmpty(textBoxMadeDate_Year.Text)
                           )
            {
                bool correct = false;
                string input;

//*****validation for Serial number
                do
                {
                    input = texboxSerialNumber.Text;

                    if (RegExValidator.IsCorrectSNumber(input))
                    {
                        correct = true;
                        serialNumber = Convert.ToInt64(texboxSerialNumber.Text);
                        break;
                    }

                    if (!correct)

                        MessageBox.Show("Incorrect field SERIAL NUMBER. It should be a 12 digits number.TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); return;


                } while (!correct);

                correct = false;
 
//*****validation for Make
                do
                {
                    input = textBox_Make.Text;

                    if (RegExValidator.IsCharacter(input))
                    {
                        correct = true;
                        make = textBox_Make.Text;
                        break;
                    }

                    if (!correct)

                        MessageBox.Show("Incorrect field Make. It should be a characters. TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); return;


               } while (!correct);
                
                correct = false;

//*****validation for Speed                
                do
                {
                    input = textBox_Speed.Text;

                    if (RegExValidator.IsDecimalValue(input))
                    {
                        correct = true;
                        speed = Convert.ToDouble(textBox_Speed.Text);
                        break;
                    }

                    if (!correct)

                        MessageBox.Show("Incorrect spead! It should be decimal number (0.00) TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); return;


                } while (!correct);

                correct = false;

//*****validation for Month 

                do
                {
                    input = textBoxMadeDate_Month.Text;

                    if (RegExValidator.IsMonth(input))
                    {
                        correct = true;
                        dm = Convert.ToInt32(textBoxMadeDate_Month.Text);
                        break;
                    }

                    if (!correct)

                        MessageBox.Show("Incorrect Month.It should be a 01-12.TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); return;


                } while (!correct);

                correct = false;
                
 //*****validation for Day 
 
                do
                {
                    input = textBoxMadeDate_Day.Text;

                    if (RegExValidator.IsDay(input))
                    {
                        correct = true;
                        dd = Convert.ToInt32(textBoxMadeDate_Day.Text);
                        break;
                    }

                    if (!correct)

                        MessageBox.Show("Incorrect Day.It should be a 01-31.TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); return;


                } while (!correct);

                correct = false;

//*****validation for Year   

                do
                {
                    input = textBoxMadeDate_Year.Text;

                    if (RegExValidator.IsYear(input))
                    {
                        correct = true;
                        dy = Convert.ToInt32(textBoxMadeDate_Year.Text);
                        break;
                    }

                    if (!correct)

                        MessageBox.Show("Incorrect Year.It should be a 2000-2029.TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); return;


                } while (!correct);
                correct = false;


                price = Convert.ToDouble(textBox_Price.Text);
                

                if (posBikeType == 1 )  
                {
                    if (!String.IsNullOrEmpty(textBox_FrameSize.Text) && 
                        !String.IsNullOrEmpty(textBox_RiderHeigth.Text))
                    {
                        //initialisation variable for object the Mountain Bike

                        frameSize = Convert.ToInt32(textBox_FrameSize.Text);
                        riderHeigth = Convert.ToInt32(textBox_RiderHeigth.Text);
                        anDate.Month = dm;
                        anDate.Day = dd;
                        anDate.Year = dy;
                        aBike = new MountainBike(serialNumber, make, speed, (EnumColor)posColor, anDate, (EnumBikeType)posBikeType, price, frameSize, riderHeigth, (EnumSuspension)posSuspType);
                        
                        BikeList.Add(aBike); 

                        listBox_Bike.Items.Add(aBike);
                    }
                    
                    else
                    {
                        MessageBox.Show("You must input data. \n Data is required....", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }

                } 

                //initialisation variable for the Road Bike

                else if (posBikeType == 2 )
                {
                    if (!String.IsNullOrEmpty(textBoxSeatTubeHeigth.Text))
                    {
                        //*****validation for Seat Heigth   

                        do
                        {
                            input = textBoxSeatTubeHeigth.Text;

                            if (RegExValidator.IsDecimalValue(input))
                            {
                                correct = true;
                                seatTubeHeight = Convert.ToDouble(textBoxSeatTubeHeigth.Text);
                                break;
                            }

                            if (!correct)

                                MessageBox.Show("Incorrect field Seat Heigth! It should be decimal number (0.00) TRY AGAIN!", "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Error); return;


                        } while (!correct);

                        anDate.Month = dm;
                        anDate.Day = dd;
                        anDate.Year = dy;
                        
                        aBike = new RoadBike(serialNumber, make, speed, (EnumColor)posColor, anDate, (EnumBikeType)posBikeType, price, seatTubeHeight, (EnumBrakesType)posBrakesType, (EnumTiresType)posTiresType);

                        BikeList.Add(aBike);
                       
                        listBox_Bike.Items.Add(aBike);

                    }
                    else
                    {
                        MessageBox.Show("You must input data.\n Data is required....", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                   

                }
            }
            else
            {
                MessageBox.Show("You must input data.\n Data is required....", "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

        }

        private void listBox_Bike_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBox_Bike.SelectedIndex;
            

            MessageBox.Show("id " + index);
            

            if (index >= 0)
            {
                groupBox_MountainBike.Enabled = true;
                groupBox_RoadBike.Enabled = false;
                this.texboxSerialNumber.Text = Convert.ToString(this.BikeList[index].SerialNumber);

            }

            else

            {
                groupBox_MountainBike.Enabled = false;
                groupBox_RoadBike.Enabled = false;
                MessageBox.Show("You did not select a bike from the list...Try again!");
            }

        }

        private void comboBox_SuspType_SelectedIndexChanged(object sender, EventArgs e)
        {
            posSuspType = this.comboBox_SuspType.SelectedIndex;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            

            foreach (Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
                
            }

            this.textBox_FrameSize.Text = "";
            this.textBox_RiderHeigth.Text = "";
            this.textBoxSeatTubeHeigth.Text = "";
            this.comboBox_BikeType.Text = Convert.ToString(this.comboBox_BikeType.Items[0]);
            this.comboBox_Color.Text = Convert.ToString(this.comboBox_Color.Items[0]);
            this.comboBox_SuspType.Text = Convert.ToString(this.comboBox_SuspType.Items[0]);
            this.comboBox_BrakesType.Text = Convert.ToString(this.comboBox_BrakesType.Items[0]);
            this.comboBox_TiresType.Text = Convert.ToString(this.comboBox_TiresType.Items[0]);
            this.texboxSerialNumber.Focus();
            this.listBox_Bike.Items.Clear();
            
            
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            this.listBox_Bike.Items.Clear();

            foreach (Bike record in BikeList)
            {
                              
               this.listBox_Bike.Items.Add(record);
                              
            }
            
        }

        private void buttonDisplayMB_Click(object sender, EventArgs e)
        {
            this.listBox_Bike.Items.Clear();
            int count = 0;

            if (BikeList.Count > 0)
            {
                foreach (Bike record in BikeList)
                {
                  if (record is MountainBike)
                    {
                        this.listBox_Bike.Items.Add(record);
                        count += 1;
                    }
                }

                if (count==0)
                {
                    MessageBox.Show("No one MountainBikes has not been found!");
                }
 
            }
            else
            {
                MessageBox.Show("Error. This list is empty!");
            }


        }

        private void buttonDisplayRB_Click(object sender, EventArgs e)
        {
            this.listBox_Bike.Items.Clear();
            int count = 0;

            if (BikeList.Count > 0)
               {
                    foreach (Bike record in BikeList)
                    {
                        if(record is RoadBike)
                    {
                        this.listBox_Bike.Items.Add(record);
                        count += 1;
                    }
                        
                    }
                if (count==0)
                {
                    MessageBox.Show("No one RoadBikes has not been found!");
                }
               }
            else
            {
                MessageBox.Show("This list is empty!");
            }
                
           
        }

                
        private void butDelete_Click(object sender, EventArgs e)
        {
            this.listBox_Bike.Focus();

            index = listBox_Bike.SelectedIndex;
           
            DialogResult result;

            result = MessageBox.Show("Do you want to delete this bike?", "Update",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    MessageBox.Show("\n Mountan bike id " + this.BikeList[index].SerialNumber + " has by delited");

                    BikeList.RemoveAt(index);
                }

                
            }

            else { MessageBox.Show("No bikes have not been deleted!"); }
         
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Bike bikeFound = null;
            bool found = false;

            if (textBoxSearch.Text != string.Empty)

            {
                long SNumberFound = Convert.ToInt64(textBoxSearch.Text);
                foreach (Bike record in BikeList)
                {
                    if (record.SerialNumber == SNumberFound)
                    {
                        found = true;
                        bikeFound = record;

                        break;
                    }
                }

                if (found == true)
                {
                    MessageBox.Show(Convert.ToString(bikeFound));
                }
                else
                {
                    MessageBox.Show("Bike " + this.textBoxSearch.Text + " Not faund!");
                }
            
            
            
            }
            else { MessageBox.Show("Please, Enter serial number"); }

            textBoxSearch.Text = ""; textBoxSearch.Focus();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void textBoxMadeDate_Month_TextChanged(object sender, EventArgs e)
        {

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            index = listBox_Bike.SelectedIndex;
                    
            
            Date anDate = new Date();

            DialogResult result;

            result = MessageBox.Show("Do you want to update this bike?", "Update",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (index >=0)
                {
                    if (posBikeType == 1)
                    {
                        groupBox_MountainBike.Enabled = true;
                        groupBox_RoadBike.Enabled = false;

                        long serialNumber = Convert.ToInt64(texboxSerialNumber.Text);
                        string make = textBox_Make.Text;
                        double speed = Convert.ToDouble(textBox_Speed.Text);
                        double price = Convert.ToDouble(textBox_Price.Text);
                        int dm = Convert.ToInt32(textBoxMadeDate_Month.Text);
                        int dd = Convert.ToInt32(textBoxMadeDate_Day.Text);
                        int dy = Convert.ToInt32(textBoxMadeDate_Year.Text);
                        int frameSize = Convert.ToInt32(textBox_FrameSize.Text);
                        int riderHeigth = Convert.ToInt32(textBox_RiderHeigth.Text);
                        anDate.Month = dm;
                        anDate.Day = dd;
                        anDate.Year = dy;
                                                
                        Bike aMountain = new MountainBike(serialNumber, make, speed, (EnumColor)posColor, anDate, (EnumBikeType)posBikeType, price, frameSize, riderHeigth, (EnumSuspension)posSuspType);
                        this.BikeList[index] = aMountain;
                        MessageBox.Show("This bike " + this.BikeList[index].SerialNumber + " updated from the list");


                    }
                    if (posBikeType == 2)
                    {
                        groupBox_MountainBike.Enabled = false;
                        groupBox_RoadBike.Enabled = true;

                        long serialNumber = Convert.ToInt64(texboxSerialNumber.Text);
                        string make = textBox_Make.Text;
                        double speed = Convert.ToDouble(textBox_Speed.Text);
                        double price = Convert.ToDouble(textBox_Price.Text);
                        int dm = Convert.ToInt32(textBoxMadeDate_Month.Text);
                        int dd = Convert.ToInt32(textBoxMadeDate_Day.Text);
                        int dy = Convert.ToInt32(textBoxMadeDate_Year.Text);
                        anDate.Month = dm;
                        anDate.Day = dd;
                        anDate.Year = dy;
                        double seatTubeHeight = Convert.ToDouble(textBoxSeatTubeHeigth.Text);
                        
                        Bike aRoad = new RoadBike(serialNumber, make, speed, (EnumColor)posColor, anDate, (EnumBikeType)posBikeType, price, seatTubeHeight, (EnumBrakesType)posBrakesType, (EnumTiresType)posTiresType);

                        this.BikeList[index] = aRoad;

                        MessageBox.Show("This bike " + this.BikeList[index].SerialNumber + " updated from the list");


                    }


                }
                
                else MessageBox.Show("You did not choose a bike!");

            }

            else MessageBox.Show("No charging done...");
        }

        private void comboBox_BrakesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            posBrakesType = this.comboBox_BrakesType.SelectedIndex;
        }

        private void comboBox_TiresType_SelectedIndexChanged(object sender, EventArgs e)
        {
            posTiresType = this.comboBox_TiresType.SelectedIndex;
        }

        private void texboxSerialNumber_Validating(object sender, CancelEventArgs e)
        {
                       
        }

        private void textBox_Make_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Make.Text != string.Empty)
            {
            }
                else MessageBox.Show("Please, Enter the Make!");

        }

        private void textBox_Speed_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Speed.Text != string.Empty)
            {
            }
            else MessageBox.Show("Please, Enter the Speed!");
        }

        private void textBoxMadeDate_Month_Validating(object sender, CancelEventArgs e)
        {

            if (textBoxMadeDate_Month.Text != string.Empty)
            {

            }
            else MessageBox.Show("Please, Enter the Month!");
        }

        private void textBoxMadeDate_Day_Validating(object sender, CancelEventArgs e)
        {
            
            if(textBoxMadeDate_Day.Text != string.Empty)
            {
                
            }
            else MessageBox.Show("Please, Enter the Day!");

        }

        private void textBoxMadeDate_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMadeDate_Year_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMadeDate_Year.Text != string.Empty)
            {
            }
            else MessageBox.Show("Please, Enter the YEAR!");
        }

        private void textBoxSeatTubeHeigth_Validating(object sender, CancelEventArgs e)
        {

            if (textBoxMadeDate_Year.Text != string.Empty)
            {
                               
            }
            
            else MessageBox.Show("Please, Enter the YEAR!");
        }

        private void textBox_FrameSize_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_FrameSize.Text != string.Empty)
            {

            }

            else MessageBox.Show("Please, Enter the Frame Size!");
        }

        private void textBox_RiderHeigth_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_RiderHeigth.Text != string.Empty)
            {

            }

            else MessageBox.Show("Please, Enter the Rider Heigth!");
        }

        private void textBoxSearch_Validating(object sender, CancelEventArgs e)
        {
        }

        private void button_Saving_Click(object sender, EventArgs e)
        {
            if (BikeList.Count > 0)
            {
                FileHandler.WriteToBinaryFile(this.BikeList);
                MessageBox.Show("ListBike saved successfully to file...");
            }
            else
            {
                MessageBox.Show("BikeList is empty!", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            
        }

        private void button_LoadingFile_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(FileHandler.binFilePath))
            {
                List<Bike> listFromFile = new List<Bike>();

                listFromFile = FileHandler.ReadFromBinaryFile();

                this.BikeList = listFromFile;

                foreach (Bike record in this.BikeList)
                {
                  if(record is MountainBike)
                    {
                        this.listBox_Bike.Items.Add(record);
                    }
                  if (record is RoadBike)
                    {
                        this.listBox_Bike.Items.Add(record);
                    }
                    
                }

                MessageBox.Show("Content loaded in BikeList");
            }
            else
            {
                MessageBox.Show("No data found");
            }

        }

        private void textBox_Speed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Make_TextChanged(object sender, EventArgs e)
        {

        }

        private void texboxSerialNumber_Validated(object sender, EventArgs e)
        {
            
        }

        

        private void texboxSerialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void texboxSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox_Price_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Price.Text != string.Empty)
            {
            }
            else MessageBox.Show("Please, Enter the price!");
        }

        private void comboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            posColor = this.comboBox_Color.SelectedIndex;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Do you want to exit", "Update",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The form is closed. This app is writen by Kryukova Svetlana");
                this.Close();
            }

            else MessageBox.Show("Continue...");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_BikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
             posBikeType = this.comboBox_BikeType.SelectedIndex;

                switch (posBikeType)
                {
                    case 0:
                        groupBox_MountainBike.Enabled = false;
                        groupBox_RoadBike.Enabled = false;
                        break;

                    case 1:

                        groupBox_MountainBike.Enabled = true;
                        groupBox_RoadBike.Enabled = false;

                        break;
                    case 2:

                        groupBox_MountainBike.Enabled = false;
                        groupBox_RoadBike.Enabled = true;
                        break;
                }
                 
        }

    }
}
