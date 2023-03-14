using System;
namespace WaterProject.Models.ViewModels
{
	public class PageInfo
	{
		public int TotalNumProjects { get; set; }
		public int ProjectsPerPage { get; set; }
		public int CurrentPage { get; set; }
		//figures out how many pages we need
		//Why do we need to do a lambda? why cant we just do an = ?
		public int TotalPages => (int)Math.Ceiling((double)TotalNumProjects / ProjectsPerPage);
	}
}

