using System.ComponentModel.DataAnnotations;

namespace DotnetSpider.Portal.Models.Docker
{
	public class AddImageRepositoryViewModel
	{
		/// <summary>
		/// 
		/// </summary>
		[Required]
		[StringLength(255, MinimumLength = 4)]
		public string Name { get; set; }

		/// <summary>
		/// registry.cn-shanghai.aliyuncs.com
		/// </summary>
		[StringLength(255)]
		[Required]
		public string Registry { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[StringLength(255)]
		[Required]
		public string Repository { get; set; }
	}
}