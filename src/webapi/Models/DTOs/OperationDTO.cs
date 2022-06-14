using System.ComponentModel.DataAnnotations;

namespace distributed_calculator.Models.DTOs {
    public class OperationDTO {
        [Required]
        public int N1 { get; set; }
        [Required]
        public int N2 { get; set; }
        [Required]
        public string operation { get; set; }
        public override string ToString() {
            return $"{N1} {operation} {N2}";
        }
    }
}