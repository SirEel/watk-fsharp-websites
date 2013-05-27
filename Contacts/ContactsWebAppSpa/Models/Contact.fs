namespace FsWeb.Models

open System
open System.ComponentModel.DataAnnotations

type Contact() = 
    let mutable firstName = ""
    let mutable lastName = ""
    let mutable phone = ""
    [<Key>] member val Id = Guid.NewGuid() with get, set
    [<Required>] member x.FirstName with get() = firstName and set v = firstName <- v
    [<Required>] member x.LastName with get() = lastName and set v = lastName <- v
    member x.Phone with get() = phone and set v = phone <- v
