using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamyad
{
   public class Stack
    {
        public Stack()
        {

        }
        static  private int _amount;
		public int Amount
		{
			get
			{
				return (_amount);
			}
			set
			{
                if (value>=30)
                {
					onX(new System.EventArgs()); //مرحله چهارم
				}
				_amount = value;
			}
		}
		public event XHandler X; //مرحله دوم
		virtual protected void onX(System.EventArgs e) //مرحله سوم
		{
			if (X != null)
				X(this, e);
		}

	
	}
}
