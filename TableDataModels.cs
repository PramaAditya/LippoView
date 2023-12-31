using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lippo.Models
{
    public class TableDataIndexModel
    {
        public string Category { get; set; }
        public List<InputTableData> DataList { get; set; }
    }

    public class TableDataEditModel
    {
        public string ReturnUrl { get; set; }
        public InputTableData Data { get; set; }
    }

    public class InputTableData
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Data")]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
    }
}