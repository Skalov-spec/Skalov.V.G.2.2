
using System;
using System.Text;

namespace medecineList
{
	public class medecineList
	{
		private medecineListItem first;
		private medecineListItem last;
		private uint numElements;
		public uint Count
		{
			get
			{
				return numElements;
			}
		}
		public medecineList()
		{
			numElements=0;
			first=last=null;
		}
		public medecineList(medecine m)
		{
			first=new medecineListItem(m);
			last=first;
			++numElements;
		}
		
		public void Addmedecine (medecine m)
		{
			if(first==null)
			{
				first=new medecineListItem(m);
			    last=first;
			}
			else
			{
				last.next=new medecineListItem(m);
				last=last.next;
			}
			++numElements;
		}
		
		public override string ToString()
		{
			StringBuilder strB=new StringBuilder(100);
			medecineListItem item =first;
			while(item!=null)
			{
				strB.AppendLine("Node: "+item.medecine.ToString());
				item=item.next;
			}
			return strB.ToString();
		}
		public medecine Findmedecine(string name_of_drug)
		{
			medecine result;
			medecineListItem item =first;
			while(item!=null)
			{
				if(name_of_drug == item.medecine.name_of_drug)
				{
					return item.medecine;
					//break;
				}
				item=item.next;
			}
			throw new System.NullReferenceException();
		}
		public medecineList FindAllmedecine (string group)
		{
			medecineList list =new medecineList();
			medecineListItem item = first;
			while(item!=null)
			{
				if(group == item.medecine.group)
				{
					list.Addmedecine(item.medecine);
				}
				item=item.next;
			}
			return list;
		}
		
	}
}
