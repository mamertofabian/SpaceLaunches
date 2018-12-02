interface RocketList {
  rockets: Rocket[];
  total: number;
  count: number;
  offset: number;
}

interface Rocket {
  id: number;
  name: string;
  familyName: string;
  configuration: string;
  defaultPads?: string;
  infoURL?: string;
  wikiURL: string;
  infoURLs: string[];
  imageSizes?: number[];
  imageURL?: string;
  smallImageUrl?: string;
}
