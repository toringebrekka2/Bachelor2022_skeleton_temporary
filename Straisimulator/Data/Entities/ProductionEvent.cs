using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Straisimulator.Data.Entities;

public class ProductionEvent
{
    [Key]
    public int Id { get; set; }
    public int ProductionId { get; set; }
    public DateTime TimeStamp { get; set; }
    
    public int EventType { get; set; }
    
    [ForeignKey(nameof(EventType))] 
    
    public ProductionEventTypes ProductionEventType { get; set; }
    
    [ForeignKey(nameof(ProductionId))]
    public Production Production { get; set; }
}