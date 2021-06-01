
using System;

namespace medecineList
{

	public class medecineListItem
	{
		public medecine medecine {get;set;}
		public medecineListItem next {get;set;}
		public medecineListItem()
		{
			medecine.code=0;
			medecine.name_of_drug = "n/d";
			medecine.group = "n/d";
			medecine.category = "n/d";
			//next=null;
		}
		public medecineListItem(byte code, string name_of_drug , string group, string category)
		{
			medecine.code = code;
			medecine.name_of_drug = name_of_drug;
			medecine.group = group;
			medecine.category = category;
			//next=null;
		}
		public medecineListItem(medecine m)
		{
			medecine = m;
			//next=null;
		}
		
	}
}
