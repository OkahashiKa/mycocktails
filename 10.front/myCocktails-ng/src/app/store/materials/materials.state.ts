// import { Injectable } from '@angular/core';
// import { State, Action, StateContext } from '@ngxs/store';
// import { of } from 'rxjs';
// import { tap, catchError } from 'rxjs/operators';
// import { MaterialModel, MaterialDetailModel } from '@mycocktails/ng-materialapi-service';
// import { MaterialAction } from 'src/app/store/materials/materials.action';
// import { MaterialsService } from 'src/app/service/api/materials/materials.service';

// export interface MaterialStateModel {
//   selectedMaterial: MaterialDetailModel;
//   materialList: MaterialModel[];
// }

// @State<MaterialStateModel>({
//   name: 'material',
//   defaults: {
//     selectedMaterial: null,
//     materialList: [],
//   },
// })

// @Injectable()
// export class MaterialState {
//   constructor(
//       private materiallSevice: MaterialsService
//   ) {}

//   @Action(MaterialAction.GetMaterial)
//   getMaterial(ctx: StateContext<MaterialStateModel>, action: MaterialAction.GetMaterial) {
//       return this.materiallSevice.getMaterial(action.materialId).pipe(
//           tap((result) => {
//               ctx.patchState({
//                   selectedMaterial: result
//               })
//           })
//       )
//   }

//   @Action(MaterialAction.GetMaterialList)
//   GetMaterialList({ getState, setState }: StateContext<MaterialStateModel>) {
//       const state = getState();
//       return this.materiallSevice.getMaterialsList().pipe(
//           tap(result => {
//               setState({
//                   ...state,
//                   materialList: result,
//               });
//           }),
//           catchError(error =>{
//               return of(error);
//           }),
//       );
//   }
// }