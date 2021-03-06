﻿using System.Collections.Generic;
using ShootingRange.BusinessObjects;

namespace ShootingRange.Repository.RepositoryInterfaces
{
  public interface IPersonDataStore : IDataStore<Person, int>
  {
    IEnumerable<Person> FindByLastName(string partialName);

    IEnumerable<Person> FindByFirstName(string partialName);
  }
}
