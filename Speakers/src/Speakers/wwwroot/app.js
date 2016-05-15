import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

export class App {
    
    configureRouter(config, router){
        config.title = 'Speakers';
        config.map([
        { route: '',              moduleId: 'noSelection',   title: 'Select'},
        { route: 'speakers/:id',  moduleId: 'speakerDetail', name:'speakers' }
        ]);
    }
}