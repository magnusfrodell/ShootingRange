﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Service.Interface
{
  public interface ISsvShooterDataWriterService
  {
    void WriteShooterData(SsvShooterData shooterData);
  }
}
