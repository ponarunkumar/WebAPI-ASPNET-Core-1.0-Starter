using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_core_web_api.Models
{
    public class ActionItem
    {
        [Key]
        public int ActionId { get; set; }
        public string ActionDesc { get; set; }
        public DateTime ActionDueDate { get; set; }
    }
}