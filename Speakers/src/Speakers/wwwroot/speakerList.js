import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

@inject(HttpClient)
export class SpeakerList {
    
    constructor(httpClient) {
        this.http = httpClient;
    }

    created() {
        return this.http.get("/api/speakers")
            .then(response => {
                this.speakers = response.content;
            });
    }

}