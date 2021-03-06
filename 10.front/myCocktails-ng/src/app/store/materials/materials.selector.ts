import { select } from "@ngrx/store";
import { Selector } from "@ngxs/store";
import { MaterialStateModel, MaterialState } from "src/app/store/materials/materials.state"

export class MaterialSelector {

  @Selector([MaterialState])
  static selectedMaterial(state: MaterialStateModel) {
    return state.selectedMaterial;
  }

  @Selector([MaterialState])
  static materialList(state: MaterialStateModel) {
    return state.materialList;
  }

  @Selector([MaterialState])
  static userMaterialList(state: MaterialStateModel) {
    return state.userMaterialList;
  }
}