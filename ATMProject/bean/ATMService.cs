using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMProject.utils;

namespace ATMProject.bean
{
    class ATMService
    {

		private LinkedList<Function> functions;

		public ATMService()
		{
		}

		public ATMService(LinkedList<Function> functionsEnabled)
		{
			this.functions = functionsEnabled;
		}

		public LinkedList<Function> getFunctionsEnabled(String bankCode, LinkedList<PeripheralsType> peripherals,
				String PAN)
		{
			LinkedList<Function> functionsEnabled = new LinkedList<Function>();
			foreach (Function function in functions)
			{
				if (!function.validateFfunction(bankCode, peripherals, PAN))
					functionsEnabled.AddLast(function);
			}
			return functions;
		}

		public void setFunctionsEnabled(LinkedList<Function> functionsEnabled)
		{
			this.functions = functionsEnabled;
		}
	}
}
