using System.Collections.Generic;

namespace MuriloSantos.PedidosApp.Application.ViewModels
{
    public class ValidationResultViewModel
    {
        public ValidationResultViewModel()
        {
            Errors = new List<string>();
        }

        public List<string> Errors { get; set; }
        public bool IsValid => Errors == null || Errors.Count == 0;
    }
}
