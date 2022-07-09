namespace Domain

open System.Security.Cryptography

type Aes<'a> = Aes of byte[]

module Aes =
    open System.Security.Cryptography

    let Encrypt =
        use aes = AesManaged()  
