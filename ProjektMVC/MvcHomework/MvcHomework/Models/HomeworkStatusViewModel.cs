using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcHomework.Models;

public class HomeworkStatusViewModel
{
    public List<Homework>? Homeworks { get; set; }
    public SelectList? Status { get; set; }
    public string? HomeworkStatus { get; set; }
    public string? SearchString { get; set; }
}
