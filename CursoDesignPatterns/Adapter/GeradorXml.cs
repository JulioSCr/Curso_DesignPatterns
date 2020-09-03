using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
	public class GeradorXml
	{
		public string GeraXml(object pObjeto)
		{
			XmlSerializer lSerializador = new XmlSerializer(pObjeto.GetType());
			string lXml;
			using (StringWriter lWriter = new StringWriter())
			{
				lSerializador.Serialize(lWriter, pObjeto);
				lXml = lWriter.ToString();
			}
			return lXml;
		}
	}
}
