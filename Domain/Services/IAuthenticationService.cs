﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyIdentityTokenBasedAuth.Domain.Responses;
using UdemyIdentityTokenBasedAuth.ResourceViewModel;
using UdemyIdentityTokenBasedAuth.Security.Token;

namespace UdemyIdentityTokenBasedAuth.Domain.Services
{
   public interface IAuthenticationService
    {

        Task<BaseResponse<UserViewModelResource>> SignUp(UserViewModelResource userViewModel);

        Task<BaseResponse<AccessToken>> SignIn(SignInViewModelResource signInViewModel);

        Task<BaseResponse<AccessToken>> CreateAccessTokenByRefreshToken(RefreshTokenViewModelResource refreshTokenViewModel);

        Task<BaseResponse<AccessToken>> RevokeRefreshToken(RefreshTokenViewModelResource refreshTokenViewModel);




    }
}
