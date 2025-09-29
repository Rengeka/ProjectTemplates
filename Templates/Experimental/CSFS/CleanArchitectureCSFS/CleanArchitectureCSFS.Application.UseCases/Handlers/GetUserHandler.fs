namespace CleanArchitectureCSFS.Application.UseCases.Handlers

open CleanArchitectureCSFS.Application.Contracts.Handlers
open CleanArchitectureCSFS.Application.Contracts.Repositories

type GetUserHandler(userRepository: IUserRepository ) =
    interface IGetUserHandler with
        member _.Handle() = userRepository.GetUser();