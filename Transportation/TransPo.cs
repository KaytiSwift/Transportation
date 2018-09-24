using System;

namespace Transportation
{
    public class TransPo
    {
        public string GetMake { get; set; }
        public string GetModel { get; set; }
        public string GetYear { get; set; }
        public string GetNumWheels { get; set; }
        public string GetColor { get; set; }
        public string GetEngineSize { get; set; }

        public int GetMPH(int value)
        {
            return value;
        }

        public int GetMPG(int value1, int value2)
        {
            int mpg = value1 * value2;
            return mpg;
        }

        public string GetWear(int miles, int temp, int tread)
        {

            string condition = " ";
            if (temp != 0)
            {
                
                int calcOne = (miles*4) / temp;
                double calcTwo = tread * .5;
                if (calcOne < calcTwo)
                {
                    condition = "UnSafe";
                }
                else
                {
                    condition = "Safe";
                }
                
            }
            else
            {
                condition = "Invalid Entry";
            }

            return condition;
        }


    }
}