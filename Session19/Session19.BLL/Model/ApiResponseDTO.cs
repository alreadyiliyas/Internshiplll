﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19.BLL.Model
{
	public class ApiResponseDTO
	{
		public bool Success { get; set; }
		public long Timestamp { get; set; }
		public string Base { get; set; }
		public DateTime Date { get; set; }
		public Dictionary<string, decimal> Rates { get; set; }
	}
}
