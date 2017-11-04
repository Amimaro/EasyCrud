import { Availability } from './availability';
import { BankInfo } from './bankinfo';
import { BestTime } from './besttime';
import { Knoledge } from './knoledge';

export class Programmer {
  id: number;
  email: string;
  name: string;
  skype: string;
  phone: string;
  linkedin: string;
  city: string;
  state: string;
  portfolio: string;
  salary: number;
  bank: string;
  link: string;
  availability: Availability;
  bankInfo: BankInfo;
  bestTime: BestTime;
  knoledge: Knoledge;
}
