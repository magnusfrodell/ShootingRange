﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ShootingRange.BusinessObjects;
using ShootingRange.Repository.Repositories;
using ShootingRange.Repository.RepositoryInterfaces;
using ShootingRange.UiBusinessObjects;

namespace ShootingRange.ViewModel
{
  public static class UiBusinessObjectMapper
  {
    public static Person ToPerson(this UiPerson uiPerson)
    {
      return new Person()
      {
        PersonId = uiPerson.PersonId,
        FirstName = uiPerson.FirstName,
        LastName = uiPerson.LastName,
        Address = uiPerson.Address,
        ZipCode = uiPerson.ZipCode,
        City = uiPerson.City,
        DateOfBirth = uiPerson.DateOfBirth,
        Email = uiPerson.Email,
        Phone = uiPerson.Phone
      };
    }

    public static Func<Person, UiPerson> ToUiPerson = person => new UiPerson
    {
      PersonId = person.PersonId,
      FirstName = person.FirstName,
      LastName = person.LastName,
      Address = person.Address,
      ZipCode = person.ZipCode,
      City = person.City,
      DateOfBirth = person.DateOfBirth,
      Email = person.Email,
      Phone = person.Phone
    };

    public static Shooter ToShooter(this UiShooter uiShooter)
    {
      return new Shooter()
      {
        ShooterId = uiShooter.ShooterId,
        ShooterNumber = uiShooter.ShooterNumber,
        PersonId = uiShooter.PersonId
      };
    }

    public static Func<Shooter, UiShooter> ToUiShooter = shooter => new UiShooter()
    {
      ShooterId = shooter.ShooterId,
      ShooterNumber = shooter.ShooterNumber,
      PersonId = shooter.PersonId
    };

    public static Func<Session, UiSession> ToUiSession = session => new UiSession
    {
      LaneNumber = session.LaneNumber,
      SessionId = session.SessionId,
      ShooterId = session.ShooterId,
      ProgramItemId = session.ProgramItemId
    };

    public static Func<UiSession, Session> ToSession = uiSession => new Session()
    {
      LaneNumber = uiSession.LaneNumber,
      SessionId = uiSession.SessionId,
      ShooterId = uiSession.ShooterId,
      ProgramItemId = uiSession.ProgramItemId

    };

    public static UiShooter FetchPerson(this UiShooter shooter, Person person)
    {
      shooter.FirstName = person.FirstName;
      shooter.LastName = person.LastName;
      return shooter;
    }

    public static UiShooter FetchPerson(this UiShooter shooter, IPersonDataStore personDataStore)
    {
      if (shooter.PersonId != null)
      {
        shooter.FetchPerson(personDataStore.FindById((int) shooter.PersonId));
      }

      return shooter;
    }

    public static UiParticipation FetchShooters(this UiParticipation participation,
      IShooterCollectionParticipationDataStore shooterCollectionParticipationDataStore,
      IShooterCollectionDataStore shooterCollectionDataStore,
      ICollectionShooterDataStore collectionShooterDataStore,
      IShooterDataStore shooterDataStore,
      IPersonDataStore personDataStore)
    {
      participation.ShooterCollections = new List<UiShooterCollection>();
      List<ShooterCollectionParticipation> shooterCollectionParticipations =
        shooterCollectionParticipationDataStore.FindByIdParticipationId(participation.ParticipationId).ToList();
      List<ShooterCollection> shooterCollections = shooterCollectionParticipations.Select(_ => shooterCollectionDataStore.FindById(_.ShooterCollectionId)).ToList();

      foreach (ShooterCollection shooterCollection in shooterCollections)
      {
        List<CollectionShooter> collectionShooters =
          collectionShooterDataStore.FindByShooterCollectionId(shooterCollection.ShooterCollectionId).ToList();

        participation.ShooterCollections.Add(new UiShooterCollection
        {
          CollectionName = shooterCollection.CollectionName,
          ShooterCollectionId = shooterCollection.ShooterCollectionId,
          Shooters = collectionShooters.Select(_ => ToUiShooter(shooterDataStore.FindById(_.ShooterId)).FetchPerson(personDataStore))
        });
      }

      return participation;
    }

    public static Func<ShooterCollection, UiShooterCollection> ToUiShooterCollection =
      shooterCollection => new UiShooterCollection
      {
        ShooterCollectionId = shooterCollection.ShooterCollectionId,
        CollectionName = shooterCollection.CollectionName
      };

    public static ShooterCollection ToShooterCollection(this UiShooterCollection uiShooterCollection)
    {
      return new ShooterCollection
      {
        ShooterCollectionId = uiShooterCollection.ShooterCollectionId,
        CollectionName = uiShooterCollection.CollectionName
      };
    }

    public static Func<Participation, UiParticipation> ToUiParticipation = participation => new UiParticipation
    {
      ParticipationId = participation.ParticipationId,
      AllowCollectionParticipation = participation.AllowCollectionParticipation,
      AllowSingleParticipation = participation.AllowSingleParticipation,
      ParticipationName = participation.ParticipationName
    };
  }
}