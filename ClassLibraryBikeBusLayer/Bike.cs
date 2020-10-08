using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBikeBusLayer
{
    
    [Serializable]
    public abstract class Bike: Object, IMovable
    {
        private long serialNumber;
        protected string make;
        protected double speed;
        protected EnumColor color;
        protected Date madeDate;
        protected EnumBikeType bikeType;
        protected double price;

        public long SerialNumber 
        { 
            get => serialNumber; 
            set => serialNumber=value; 
        }
        
        public Bike(long serialNumber, string make, double speed, EnumColor color,
                        Date madeDate, EnumBikeType bikeType, double price)
        {
            this.serialNumber = serialNumber;
            this.make = make;
            this.speed = speed;
            this.color = color;
            this.madeDate = madeDate;
            this.bikeType = bikeType;
            this.price = price;
        }

        public virtual double GetMaxSpeed()
        {
            if (this.bikeType == EnumBikeType.mountain_Bike)
            {
                return this.speed = 20;
            }

            else
            {
                return this.speed = 40;
            }
        }

       public abstract void SpeedUp(double newSpeed);

                          
        public override string ToString()
        {
            return
                    " SerialNumber: " + this.serialNumber + " |"+ 
                    " Made: " + this.make + " |" +
                    " Speed: " + this.speed + " |" +
                    " Color: " + this.color + " |" +
                    " MadeDate: " + this.madeDate + " |" +
                    " BikeType: " + this.bikeType + " |" +
                    " Price: " + this.price+" |";

        }

  }
}

