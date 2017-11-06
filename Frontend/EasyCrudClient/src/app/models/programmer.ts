import { Availability } from './availability';
import { BankInfo } from './bankinfo';
import { BestTime } from './besttime';
import { Knoledge } from './knoledge';

export class Programmer {
  id: number = null;
  email: string = null;
  name: string = null;
  skype: string = null;
  phone: string = null;
  linkedin: string = null;
  city: string = null;
  state: string = null;
  portfolio: string = null;
  salary: number = null;
  bank: string = null;
  link: string = null;
  availability: Availability = null;
  bankInfo: BankInfo = null;
  bestTime: BestTime = null;
  knoledge: Knoledge = null;
}
