using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBikeBusLayer
{
    [Serializable]
    public class MountainBike : Bike
    {
        private int frameSize;
        private int riderHeigth;
        private EnumSuspension suspension;

        public int FrameSize
        {
            get => frameSize;
            set => frameSize = value;
        }

        public int RiderHeigth
        {
            get => riderHeigth;
            set => riderHeigth = value;
        }

        public EnumSuspension Suspension
        {
            get => suspension;
            set => suspension = value;
        }

        
        public MountainBike(long serialNumber, string make, double speed, EnumColor color,
                            Date madeDate, EnumBikeType bikeType, double price,
                            int frameSize, int riderHeigth, EnumSuspension suspensionType)
                           : base(serialNumber, make, speed, color, madeDate, bikeType, price)

        {
            this.frameSize = frameSize;
            this.riderHeigth = riderHeigth;
            this.suspension = suspensionType;
        }

        
        public override string ToString()
        {
            return base.ToString() + " FrameSize: " + this.frameSize + " |" +
                                     " RiderHeigth: " + this.riderHeigth + " |" +
                                     " Suspension: " + this.suspension; 
                                    
        }

        public override double GetMaxSpeed()
        {
            return base.GetMaxSpeed();

        }


       public override void SpeedUp(double newSpeed)
        {
            if (this.speed + newSpeed < GetMaxSpeed())
            {
                this.speed += newSpeed;
            }

        }

    }
}
