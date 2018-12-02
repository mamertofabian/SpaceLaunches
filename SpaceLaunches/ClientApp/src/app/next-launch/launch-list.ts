interface LaunchList {
  launches: Launch[];
  total: number;
  offset: number;
  count: number;
}

interface Launch {
  id: number;
  name: string;
  windowStart: string;
  windowEnd: string;
  net: string;
  isoStart: string;
  isoEnd: string;
  isoNet: string;
  status: number;
  statusDesc: string;
  location: Location;
  rocket: Rocket;
}

interface Rocket {
  id: number;
  name: string;
  familyName: string;
  imageUrl: string;
}

interface Location {
  id: number;
  name: string;
  countryCode: string;
}
