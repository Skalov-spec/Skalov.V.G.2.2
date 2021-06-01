using System;

namespace medecineList
{

	public class  medecine : IEquatable<medecine>
	{
		public string name_of_drug{get;set;}
		public string group{get;set;}
		public string category{get;set;}
		public byte code{get;set;}
		
		public medecine()
		{
			code = 0;
			name_of_drug = group = category = " ";
		}
		public medecine(string name_of_drug, string group, string category, byte code = 25)
		{
			this.name_of_drug=name_of_drug;
			this.group = group;
			this.category = category;
			this.code = code;
		}
		public override string ToString()
		{
			return name_of_drug + " " + group + " "+ category + " "+ code;
		} 
		
		public override bool Equals(object obj)
		{
			if (obj is medecine)
				return Equals((medecine)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(medecine other)
		{
			// add comparisions for all members here
			if(this.name_of_drug !=other.name_of_drug)
				return false;
			if(group != other.group)
				return false;
			if(category != other.category)
				return false;
			if(code != other.code)
				return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return name_of_drug.GetHashCode();
		}
		
		public static bool operator ==(medecine left, medecine right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(medecine left, medecine right)
		{
			return !left.Equals(right);
		}
	}
}
