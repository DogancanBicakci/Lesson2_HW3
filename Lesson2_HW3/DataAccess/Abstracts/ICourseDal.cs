﻿using Lesson2_HW3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HW3.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course);

}
