using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMProject.utils;

namespace ATMProject.bean
{
    class Function
    {

		private Guid id;
		private String name;
		private String descritpion;
		private bool enabled;
		private bool multisession;
		private FunctionType type;
		private LinkedList<PeripheralsType> peripherals;
		private Dictionary<String, String> parameters;
		LinkedList<String> bankCodes;
		LinkedList<String> bins;

		public Function()
		{
			this.id = Guid.NewGuid();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="descritpion"></param>
		/// <param name="enabled"></param>
		/// <param name="multisession"></param>
		/// <param name="type"></param>
		/// <param name="peripherals"></param>
		/// <param name="parameters"></param>
		/// <param name="bankCodes"></param>
		/// <param name="bins"></param>
		public Function(String name, String descritpion, bool enabled, bool multisession, FunctionType type,
				LinkedList<PeripheralsType> peripherals, Dictionary<String, String> parameters,
				LinkedList<String> bankCodes, LinkedList<String> bins)
		{
			this.id = Guid.NewGuid();
			this.name = name;
			this.descritpion = descritpion;
			this.enabled = enabled;
			this.multisession = multisession;
			this.type = type;
			this.peripherals = peripherals;
			this.parameters = parameters;
			this.bankCodes = bankCodes;
			this.bins = bins;
		}

		public Guid getId()
		{
			return id;
		}

		public void setId(Guid id)
		{
			this.id = id;
		}

		public String getName()
		{
			return name;
		}

		public void setName(String name)
		{
			this.name = name;
		}

		public String getDescritpion()
		{
			return descritpion;
		}

		public void setDescritpion(String descritpion)
		{
			this.descritpion = descritpion;
		}

		public bool isEnabled()
		{
			return enabled;
		}

		public void setEnabled(bool enabled)
		{
			this.enabled = enabled;
		}

		public bool isMultisession()
		{
			return multisession;
		}

		public void setMultisession(bool multisession)
		{
			this.multisession = multisession;
		}

		public FunctionType getType()
		{
			return type;
		}

		public void setType(FunctionType type)
		{
			this.type = type;
		}

		public LinkedList<PeripheralsType> getPeripherals()
		{
			return peripherals;
		}

		public void setPeripherals(LinkedList<PeripheralsType> peripherals)
		{
			this.peripherals = peripherals;
		}

		public Dictionary<String, String> getParameters()
		{
			return parameters;
		}

		public void setParameters(Dictionary<String, String> parameters)
		{
			this.parameters = parameters;
		}

		public LinkedList<String> getBankCodes()
		{
			return bankCodes;
		}

		public void setBankCodes(LinkedList<String> bankCodes)
		{
			this.bankCodes = bankCodes;
		}

		public LinkedList<String> getBins()
		{
			return bins;
		}

		public void setBins(LinkedList<String> bins)
		{
			this.bins = bins;
		}

		public String toString()
		{
			return "Function [\nid=" + id + "\nname=" + name + "\ndescritpion=" + descritpion + "\nenabled=" + enabled
					+ "\nmultisession=" + multisession + "\ntype=" + type + "\nperipherals=" + peripherals + "\nparameters="
					+ parameters + "\nbankCodes=" + bankCodes + "\nbins=" + bins + "\n]";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bankCode"></param>
		/// <param name="peripherals"></param>
		/// <param name="PAN"></param>
		/// <returns></returns>
		public bool validateFfunction(String bankCode, LinkedList<PeripheralsType> peripherals, String PAN)
		{
			if (this.verifyEnabled() & this.verifyBankCode(bankCode) & this.verifyPAN(PAN)
					& this.verifyPeripherals(peripherals))
				return true;
			return false;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public bool verifyEnabled()
		{
			return this.enabled;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="peripherals"></param>
		/// <returns></returns>
		public bool verifyPeripherals(LinkedList<PeripheralsType> peripherals)
		{
			foreach(PeripheralsType peripherals1 in peripherals)
            {
				if (!this.peripherals.Contains(peripherals1)) return false;
            }
			return true;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bankCode"></param>
		/// <returns></returns>
		public bool verifyBankCode(String bankCode)
		{
			return (this.bankCodes.Contains(bankCode));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="PAN"></param>
		/// <returns></returns>
		public bool verifyPAN(String PAN)
		{
			return (this.bins.Contains(PAN.Substring(0, 5)));
		}

	}
}
