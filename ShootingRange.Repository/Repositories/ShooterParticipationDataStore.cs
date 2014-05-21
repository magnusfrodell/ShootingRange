﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using ShootingRange.BusinessObjects;
using ShootingRange.Entities;
using ShootingRange.Repository.Mapper;

namespace ShootingRange.Repository.Repositories
{
  public class ShooterParticipationDataStore : IShooterParticipationDataStore
  {
    private SqlRepository<t_shooterparticipation> _sqlRepository;
    private Func<t_shooterparticipation, ShooterParticipation> _selector;

    public ShooterParticipationDataStore(DbContext context)
    {
      _sqlRepository = new SqlRepository<t_shooterparticipation>(context);
      _selector = shooterParticipation => new ShooterParticipation()
      {
        ShooterParticipationId = shooterParticipation.ShooterParticipationId,
        ParticipationId =  shooterParticipation.ParticipationId,
        ShooterId = shooterParticipation.ShooterId,
      };
    }

    public void Revert()
    {
      _sqlRepository.Revert();
    }

    public void Create(ShooterParticipation shooterParticipation)
    {
      t_shooterparticipation entity = new t_shooterparticipation();
      entity.UpdateEntity(shooterParticipation);
      _sqlRepository.Insert(entity);
    }

    public ShooterParticipation FindById(int id)
    {
      return _sqlRepository.Find(_ => _.ShooterParticipationId == id).Select(_selector).Single();
    }

    public IEnumerable<ShooterParticipation> GetAll()
    {
      return _sqlRepository.GetAll().ToList().Select(_selector);
    }

    public void Update(ShooterParticipation shooterParticipation)
    {
      t_shooterparticipation entity =
        _sqlRepository.Find(_ => _.ShooterParticipationId == shooterParticipation.ShooterParticipationId).Single();
      entity.UpdateEntity(shooterParticipation);
      _sqlRepository.Commit();
    }

    public void Delete(ShooterParticipation shooterParticipation)
    {
      t_shooterparticipation entity =
        _sqlRepository.Find(_ => _.ShooterParticipationId == shooterParticipation.ShooterParticipationId).Single();
      _sqlRepository.Delete(entity);
    }

    public IEnumerable<ShooterParticipation> FindByShooterId(int shooterId)
    {
      return _sqlRepository.Find(shooterParticipation => shooterParticipation.ShooterId == shooterId).Select(_selector);
    }

    public IEnumerable<ShooterParticipation> FindByParticipationId(int participationId)
    {
      return
        _sqlRepository.Find(shooterParticipation => shooterParticipation.ParticipationId == participationId)
          .Select(_selector);
    }
  }
}
