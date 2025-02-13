﻿using System;
using System.Collections.Generic;

namespace PatientMonitoringSystem.ViewModels
{
	public class BedsideSystemViewModel
	{
		public string Name { get; set; }

		public Guid Id { get; set; }

		public IEnumerable<Guid> ModuleIds { get; set; }
	}
}
