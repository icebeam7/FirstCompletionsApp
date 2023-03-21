using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCompletionsApp
{
	public class CompletionRequest
	{
		public string model { get; set; }
		public string prompt { get; set; }
		public float temperature { get; set; }
		public int max_tokens { get; set; }
		public int top_p { get; set; }
		public int frequency_penalty { get; set; }
		public int presence_penalty { get; set; }
	}

}
