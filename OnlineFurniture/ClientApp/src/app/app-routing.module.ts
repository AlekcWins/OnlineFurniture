import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from './components/home/home.component';
import {CartComponent} from './components/cart/cart.component';
import {CheckoutComponent} from './components/checkout/checkout.component';
import {ProductComponent} from './components/product/product.component';
import {ThankyouComponent} from './components/thankyou/thankyou.component';
import {UserComponent} from './user/user.component';
import {RegistrationComponent} from './user/registration/registration.component';
import {LoginComponent} from './user/login/login.component';
import {LogoutComponent} from './user/logout/logout.component';
import {MyAccountComponent} from './my-account/my-account.component';
import {AuthGuard} from './auth/auth.guard';
import {AdmincomponentComponent} from './admin-panel/admincomponent/admincomponent.component';
import {ForbiddenComponent} from './forbidden/forbidden.component';


const routes: Routes = [
  {
    path: '', component: HomeComponent
  },
  {
    path: 'product/:id', component: ProductComponent
  },
  {
    path: 'cart', component: CartComponent
  },
  {
    path: 'checkout', component: CheckoutComponent
  },
  {
    path: 'thankyou', component: ThankyouComponent
  },
  {
    path: 'my-account', component: MyAccountComponent, canActivate: [AuthGuard]
  },
  {
    path: 'admin-panel', component: AdmincomponentComponent, canActivate: [AuthGuard], data: {permittedRoles: ['Admin']}
  },
  {
    path: 'forbidden', component: ForbiddenComponent
  },

  { path: 'user', component: UserComponent, children: [
    {path: 'registration', component: RegistrationComponent},
    {path: 'login', component: LoginComponent},
    {path: 'logout', component: LogoutComponent},
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
