namespace FsWeb.Repositories

open System.Data.Entity
open FsWeb.Models

type ContactsContext() =
    inherit DbContext("ContactEntities")

    do Database.SetInitializer(new CreateDatabaseIfNotExists<ContactsContext>())

    [<DefaultValue()>]
    val mutable contacts : IDbSet<Contact>

    member x.Contacts with get() = x.contacts and set v = x.contacts <- v

type ContactsRepository() =
    
    member x.GetAll() =

        use context = new ContactsContext()
        context.Contacts |> Seq.toList

    member x.AddNew(contact) =

        use context = new ContactsContext()
        context.Contacts.Add(contact) |> ignore
        context.SaveChanges()