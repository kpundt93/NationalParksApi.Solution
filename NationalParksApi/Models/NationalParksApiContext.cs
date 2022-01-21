using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Models
{
  public class NationalParksApiContext : DbContext
  {
    public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options) : base(options)
    {

    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Crater Lake", State = "OR", Description = "Crater Lake lies in the caldera of Mount Mazama formed 7,700 years ago after an eruption. It is the deepest lake in the United States and is known for its blue color and water clarity. There are two islands in the lake, and, with no inlets or outlets, all water comes through precipitation.", Visited = true },
          new Park { ParkId = 2, Name = "Mount Rainer", State = "WA", Description = "Mount Rainier, an active volcano, is the most prominent peak in the Cascades, and it is covered by 26 named glaciers including Carbon Glacier and Emmons Glacier, the largest in the continental United States. The mountain is popular for climbing, and more than half of the park is covered by subalpine and alpine forests.", Visited =  true},
          new Park { ParkId = 3, Name = "North Cascades", State = "WA", Description = "This complex includes the two units of the National Park and the Ross Lake and Lake Chelan National Recreation Areas. There are numerous glaciers, and popular hiking and climbing areas are Cascade Pass, Mount Shuksan, Mount Triumph, and Eldorado Peak.", Visited = false },
          new Park { ParkId = 4, Name = "Olympic", State = "WA", Description = "Situated on the Olympic Peninsula, this park ranges from Pacific shoreline with tide pools to temperate rainforests to Mount Olympus. The glaciated Olympic Mountains overlook the Hoh Rain Forest and Quinault Rain Forest, the wettest area of the continental United States.", Visited = false },
          new Park { ParkId = 5, Name = "Redwood", State = "CA", Description = "This park and the co-managed state parks protect almost half of all remaining Coastal Redwoods, the tallest trees on Earth. There are three large river systems in this very seismically active area, and the 37 miles (60 km) of protected coastline have tide pools and seastacks. The prairie, estuary, coast, river, and forest ecosystems have varied animal and plant species.", Visited = true },
          new Park { ParkId = 6, Name = "Lassen Volcanic", State = "CA", Description = "Lassen Peak, the largest plug dome volcano in the world, is joined by all three other types of volcanoes in this park: shield, cinder dome, and composite. Other than the volcano, which last erupted in 1915, the park has hydrothermal areas, including fumaroles, boiling pools, and steaming ground, heated by molten rock under the peak.", Visited = false }
        );
    }
  }
}