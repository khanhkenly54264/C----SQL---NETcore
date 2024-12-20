using System;
using System.Collections.Generic;

namespace xuong_moc.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string? Image { get; set; }

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Urls { get; set; }

    public int Orders { get; set; }

    public string? Type { get; set; }

    public string? Notes { get; set; }

    public byte Status { get; set; }

}
