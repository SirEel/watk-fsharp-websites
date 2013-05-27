namespace FsWeb.Controllers

open System.Web.Http
open FsWeb.Models
open FsWeb.Repositories

type ContactsController(repository : ContactsRepository) =
    inherit ApiController()

    new() = new ContactsController(new ContactsRepository())

    member x.Get() = 
        repository.GetAll()

    member x.Post ([<FromBody>] contact) =    
        repository.AddNew(contact)