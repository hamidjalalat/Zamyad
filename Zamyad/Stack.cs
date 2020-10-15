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
        private int _amount;
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
					onX(new System.EventArgs()); //4
				}
				_amount = value;
			}
		}
		public event XHandler X; //2
		virtual protected void onX(System.EventArgs e) //3
		{
			if (X != null)
				X(this, e);
		}

	
	}
}
