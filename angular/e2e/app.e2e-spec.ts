import { StackifySupportTemplatePage } from './app.po';

describe('StackifySupport App', function() {
  let page: StackifySupportTemplatePage;

  beforeEach(() => {
    page = new StackifySupportTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
