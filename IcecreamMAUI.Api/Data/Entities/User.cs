using System.ComponentModel.DataAnnotations;

namespace IcecreamMAUI.Api.Data.Entities;

public class User
{
    [Key]
    public Guid ID { get; set; }

    [Required, MaxLength(30)]
    public string Name { get; set; }

    [Required, MaxLength(100)]
    public string Email { get; set; }

    [Required, MaxLength(150)]
    public string Address { get; set; }

    [Required, MaxLength(20)]
    public string Salt { get; set; }

    [Required, MaxLength(180)]
    public string Hash { get; set; }
}

public class Icecream
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Range(0.1, double.MaxValue)]
    public double Price { get; set; }

    [Required, MaxLength(180)]
    public string Image { get; set; }

    public ICollection<IcecreamOption> Options { get; set; }
}

public class IcecreamOption
{
    public int IcecreamId { get; set; }

    [Required, MaxLength(50)]
    public string Flavor { get; set; }

    [Required, MaxLength(50)]
    public string Topping { get; set; }

    public virtual Icecream Icecream { get; set; }
}

public class order
{
    [Key]
    public long Id { get; set; }

    public DateTime OrderAt { get; set; } = DateTime.Now;

    public Guid CustomerId { get; set; }

    [Required, MaxLength(30)]
    public string CustomerName { get; set; }

    [Required, MaxLength(100)]
    public string CustomerEmail { get; set; }

    [Required, MaxLength(150)]
    public string CustomerAddress { get; set; }

    [Range(0.1, double.MaxValue)]
    public double TotalPrice { get; set; }
}