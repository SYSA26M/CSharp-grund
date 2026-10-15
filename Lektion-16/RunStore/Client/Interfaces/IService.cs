using System;
using System.Collections.Generic;

namespace Client.Interfaces;

public interface IService<T> where T : class
{
    List<T> ListAll();
    void Add(T data);
}
