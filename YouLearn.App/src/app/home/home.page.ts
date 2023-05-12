import { Component } from '@angular/core';
import { LoadingController, NavController,NavParams } from '@ionic/angular';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor(public navCtrl : NavController, private loadingCtrl : LoadingController) {

  }
  buscarVideo(tag : string)
  {
    console.log(tag);
    if(tag == null || tag.trim()=='')
    {
      return;
    }
    //chama a api para obter os videos
    this.loadVideos(tag);

  }

  loadVideos(tag:string)
  {
    let loader = this.loadingCtrl.create({
      message: "Aguarde...",
      duration:3000
    }).finally();
  }
}
