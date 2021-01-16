using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHWÖzge
{
    class Cafe
    {
        //Default
        public Cafe()
        {
            newlatte_Coff = 0.0;
            newexpres_Coff = 0.0;
            newilatte_Coff = 0.0;
            newvCoffee_Coff = 0.0;
            newcappuc_Coff = 0.0;
            newaCoffee_Coff = 0.0;
            newamCoffee_Coff = 0.0;
            newiCappuccino_Coff = 0.0;

            newcCake_Cake = 0.0;
            newrVelvet_Cake = 0.0;
            newbCake_Cake = 0.0;
            newyCake_Cake = 0.0;
            newchoCake_Cake = 0.0;
            newcreCake_Cake = 0.0;
            newcarCake_Cake = 0.0;
            newwCake_Cake = 0.0;
        }

        //Overload
        public Cafe(double latte_Coff, double expres_Coff, double ilatte_Coff, double vCoffee_Coff, double cappuc_Coff,double aCoffee_Coff,
            double amCoffee_Coff, double iCappuccino_Coff,
            double cCake_Cake, double rVelvet_Cake, double bCake_Cake, double yCake_Cake,
            double choCake_Cake, double creCake_Cake, double carCake_Cake, double wCake_Cake)
        {
            //Coffee
            newlatte_Coff = latte_Coff;
            newexpres_Coff = expres_Coff;
            newilatte_Coff = ilatte_Coff;
            newvCoffee_Coff = vCoffee_Coff;
            newcappuc_Coff = cappuc_Coff;
            newaCoffee_Coff = aCoffee_Coff;
            newamCoffee_Coff = amCoffee_Coff;
            newiCappuccino_Coff = iCappuccino_Coff;

            //Cakes
            newcCake_Cake = cCake_Cake;
            newrVelvet_Cake = rVelvet_Cake;
            newbCake_Cake = bCake_Cake;
            newyCake_Cake = yCake_Cake;
            newchoCake_Cake = choCake_Cake;
            newcreCake_Cake = creCake_Cake;
            newcarCake_Cake = carCake_Cake;
            newwCake_Cake = wCake_Cake;
        }


        //
        public double getlatte_Coff()
        {
            return newlatte_Coff;
        }
        public double getexpres_Coff()
        {
            return newexpres_Coff;
        }
        public double getilatte_Coff()
        {
            return newilatte_Coff;
        }
        public double getvCoffee_Coff()
        {
            return newvCoffee_Coff;
        }
        public double getcappuc_Coff()
        {
            return newcappuc_Coff;
        }
        public double getaCoffee_Coff()
        {
            return newaCoffee_Coff;
        }
        public double getamCoffee_Coff()
        {
            return newamCoffee_Coff;
        }
        public double getiCappuccino_Coff()
        {
            return newiCappuccino_Coff;
        }
        public double getcCake_Cake()
        {
            return newcCake_Cake;
        }
        public double getrVelvet_Cake()
        {
            return newrVelvet_Cake;
        }
        public double getbCake_Cake()
        {
            return newbCake_Cake;
        }
        public double getyCake_Cake()
        {
            return newyCake_Cake;
        }
        public double getchoCake_Cake()
        {
            return newchoCake_Cake;
        }
        public double getcreCake_Cake()
        {
            return newcreCake_Cake;
        }
        public double getcarCake_Cake()
        {
            return newcarCake_Cake;
        }
        public double getwCake_Cake()
        {
            return newwCake_Cake;
        }






        //
        private double newlatte_Coff;
        private double newexpres_Coff;
        private double newilatte_Coff;
        private double newvCoffee_Coff;
        private double newcappuc_Coff;
        private double newaCoffee_Coff;
        private double newamCoffee_Coff;
        private double newiCappuccino_Coff;


        private double newcCake_Cake;
        private double newrVelvet_Cake;
        private double newbCake_Cake;
        private double newyCake_Cake;
        private double newchoCake_Cake;
        private double newcreCake_Cake;
        private double newcarCake_Cake;
        private double newwCake_Cake;



    }
}
