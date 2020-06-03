import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TabsPage } from './tabs.page';
import { LoginPage } from '../login/login.page';

const routes: Routes = [
  {
    path: 'login',
    component: LoginPage,
    loadChildren: () => import('../login/login.module').then(m => m.LoginPageModule)
  },
  {
    path: 'tabs',
    component: TabsPage,
    children: [
      {
        path: 'perfil',
        loadChildren: () => import('../tab1/tab1.module').then(m => m.Tab1PageModule)
      },
      {
        path: 'cuenta',
        loadChildren: () => import('../tab2/tab2.module').then(m => m.Tab2PageModule)
      },
      {
        path: 'operaciones',
        loadChildren: () => import('../tab3/tab3.module').then(m => m.Tab3PageModule)
      },
      {
        path: 'operaciones/:operacionID',
        loadChildren: () => import('../tab3/operacion-detalle/operacion-detalle.module').then(m => m.OperacionDetallePageModule)
      },
      {
        path: 'operaciones/monedero/:operacionID',
        loadChildren: () => import ('../tab3/operacion-detalle-m/operacion-detalle-m.module').then(m => m.OperacionDetalleMPageModule)
      },
      {
        path: 'operaciones/tarjeta/:operacionID',
        loadChildren: () => import ('../tab3/operacion-detalle-t/operacion-detalle-t.module').then(m => m.OperacionDetalleTPageModule)
      },
      {
        path: 'operaciones/pago',
        loadChildren: () => import ('../tab3/pago/pago.module').then(m => m.PagoPageModule)
      },
      {
        path: '',
        redirectTo: '/tabs/tab2',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: '/login',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TabsPageRoutingModule {}
