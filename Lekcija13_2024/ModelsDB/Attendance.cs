﻿using System;
using System.Collections.Generic;

namespace Lekcija13_2024.ModelsDB;

public partial class Attendance
{
    public int? StudentId { get; set; }

    public int? LectureId { get; set; }

    public string? Attendance1 { get; set; }

    public virtual Lecture? Lecture { get; set; }

    public virtual Student? Student { get; set; }
}
