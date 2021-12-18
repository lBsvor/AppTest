// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

import { AppPage } from './app.po';

describe('TestApp App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display application title: TestApp', async () => {
    await page.navigateTo();
    expect(await page.getAppTitle()).toEqual('TestApp');
  });
});
