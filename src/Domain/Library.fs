namespace Domain

open System




type Email = Email of string

type CreateAt = CreateAt of DateTime

type UpdateAt = UpdateAt of DateTime

type Content = Content of Aes<string>


