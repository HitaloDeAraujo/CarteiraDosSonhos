﻿using CDS.OpenBanking.Accounts.Domain.Entities.Personal;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Repository;
using CDS.OpenBanking.Accounts.Infra.OpenBankingResult;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Personal.Infra.Mock
{
    public class PersonalRepositoryMock : IPersonalRepository
    {
        public async Task<ICollection<Identification>> GetIdentifications()
        {
            var json = @"
                        {
                          'data': [
                            {
                              'updateDateTime': '2021-05-21T08:30:00Z',
                              'personalId': '578-psd-71md6971kjh-2d414',
                              'brandName': 'Organização A',
                              'civilName': 'Juan Kaique Cláudio Fernandes',
                              'socialName': 'string',
                              'birthDate': '2021-05-21',
                              'maritalStatusCode': 'SOLTEIRO',
                              'maritalStatusAdditionalInfo': '',
                              'sex': 'FEMININO',
                              'companyCnpj': [
                                '01773247000103',
                                '01773247000563'
                              ],
                              'documents': {
                                'cpfNumber': '25872252137',
                                'passportNumber': '75253468744594820620',
                                'passportCountry': 'CAN',
                                'passportExpirationDate': '2021-05-21',
                                'passportIssueDate': '2021-05-21'
                              },
                              'otherDocuments': [
                                {
                                  'type': 'CNH',
                                  'typeAdditionalInfo': 'NA',
                                  'number': '15291908',
                                  'checkDigit': 'P',
                                  'additionalInfo': 'SSP/SP',
                                  'expirationDate': '2021-05-21'
                                }
                              ],
                              'hasBrazilianNationality': false,
                              'nationality': [
                                {
                                  'otherNationalitiesInfo': 'CAN',
                                  'documents': [
                                    {
                                      'type': 'SOCIAL SEC',
                                      'number': '423929299',
                                      'expirationDate': '2021-05-21',
                                      'issueDate': '2021-05-21',
                                      'country': 'Brasil',
                                      'typeAdditionalInfo': 'Informações adicionais.'
                                    }
                                  ]
                                }
                              ],
                              'filiation': [
                                {
                                  'type': 'PAI',
                                  'civilName': 'Marcelo Cláudio Fernandes',
                                  'socialName': 'NA'
                                }
                              ],
                              'contacts': {
                                'postalAddresses': [
                                  {
                                    'isMain': true,
                                    'address': 'Av Naburo Ykesaki, 1270',
                                    'additionalInfo': 'Fundos',
                                    'districtName': 'Centro',
                                    'townName': 'Marília',
                                    'ibgeTownCode': '3550308',
                                    'countrySubDivision': 'SP',
                                    'postCode': '17500001',
                                    'country': 'Brasil',
                                    'countryCode': 'BRA',
                                    'geographicCoordinates': {
                                      'latitude': '-90.8365180',
                                      'longitude': '-180.836519'
                                    }
                                  }
                                ],
                                'phones': [
                                  {
                                    'isMain': true,
                                    'type': 'FIXO',
                                    'additionalInfo': 'Informações adicionais.',
                                    'countryCallingCode': '55',
                                    'areaCode': '19',
                                    'number': '29875132',
                                    'phoneExtension': '932'
                                  }
                                ],
                                'emails': [
                                  {
                                    'isMain': true,
                                    'email': 'karinafernandes-81@br.inter.net'
                                  }
                                ]
                              }
                            }
                          ],
                          'links': {
                            'self': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'first': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'prev': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'next': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'last': 'https://api.banco.com.br/open-banking/api/v1/resource'
                          },
                          'meta': {
                            'totalRecords': 1,
                            'totalPages': 1,
                            'requestDateTime': '2021-05-21T08:30:00Z'
                          }
                        }
";

            IdentificationResult result = JsonConvert.DeserializeObject<IdentificationResult>(json);

            return await Task.Run(() => { return result.Data; });
        }
    }
}