using System;
namespace dotnetApi.Models.Domain
{
	public class Walk
	{
		public Guid Id { get; set; }

		public required string Name { get; set; }

		public required string Description { get; set; }

		public Double lengthInKm { get; set; }

		public string? walkImageUrl { get; set; }

		public Guid DifficultyId { get; set; }

		public Guid RegionId { get; set; }

		public required Difficulty Difficulty { get; set; } //this property basically reference the difficulty id

        public required Region Region { get; set; } //this property basically reference the Region id

    }
}

