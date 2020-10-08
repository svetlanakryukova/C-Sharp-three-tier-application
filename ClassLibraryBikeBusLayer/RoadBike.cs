using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBikeBusLayer
{
    [Serializable]
    public class RoadBike : Bike
    {
        private double seatHeight;
        private EnumBrakesType brakesType;
        private EnumTiresType tiresType;

        public double SeatHeight
        {
            get => seatHeight;
            set => seatHeight = value;
        }

        public EnumBrakesType BrakesType
        {
            get => brakesType;
            set => brakesType = value;
        }
        public EnumTiresType TireType
        {
            get => tiresType;
            set => tiresType = value;
        }

        
       public RoadBike(long serialNumber, string make, double speed, EnumColor color,
                            Date madeDate, EnumBikeType bikeType, double price,
                            double seatTubeHeight, EnumBrakesType brakesType, EnumTiresType tireType) :
                        base(serialNumber, make, speed, color, madeDate, bikeType, price)
        {
            this.seatHeight = seatTubeHeight;
            this.brakesType = brakesType;
            this.tiresType = tireType;
        }

    

        public override string ToString()
        {
            return base.ToString() + " SeatHeight: " + this.seatHeight + " |" +
                                     " Brakes: " + this.brakesType + " |" +
                                     " Tires: " + this.tiresType;
        }

        public override double GetMaxSpeed()
        {
            return base.GetMaxSpeed();

        }

               
        public override void SpeedUp(double newSpeed)
        {
            if (this.speed+newSpeed < GetMaxSpeed())
            {
                this.speed += newSpeed;
            }

        }

    }
}
