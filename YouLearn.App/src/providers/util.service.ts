import { Injectable } from "@angular/core";
import { LoadingController } from "@ionic/angular";

@Injectable()
export class utilService{
    constructor(public loadCtr : LoadingController){

    }
    public showLoading (messagem : string = "Processando...") : any {
        let loading  =  this.loadCtr.create({message:messagem});

        return loading;
    }
}